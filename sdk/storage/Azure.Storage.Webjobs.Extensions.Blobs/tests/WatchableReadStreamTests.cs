﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs.Host.Blobs;
using Microsoft.Azure.WebJobs.Host.Protocols;
using Microsoft.Azure.WebJobs.Host.UnitTests.Blobs.Bindings;
using Moq;
using NUnit.Framework;

namespace Microsoft.Azure.WebJobs.Host.UnitTests.Blobs
{
    public class WatchableReadStreamTests
    {
        [TestCase(false)]
        [TestCase(true)]
        public void CanRead_DelegatesToInnerStreamCanRead(bool expected)
        {
            // Arrange
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock.Setup(s => s.CanRead).Returns(expected);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            // Act
            bool canRead = product.CanRead;

            // Assert
            Assert.AreEqual(expected, canRead);
        }

        [TestCase(false)]
        [TestCase(true)]
        public void CanSeek_DelegatesToInnerStreamCanSeek(bool expected)
        {
            // Arrange
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock.Setup(s => s.CanSeek).Returns(expected);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            // Act
            bool canSeek = product.CanSeek;

            // Assert
            Assert.AreEqual(expected, canSeek);
        }

        [TestCase(false)]
        [TestCase(true)]
        public void CanTimeout_DelegatesToInnerStreamCanTimeout(bool expected)
        {
            // Arrange
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock.Setup(s => s.CanTimeout).Returns(expected);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            // Act
            bool canTimeout = product.CanTimeout;

            // Assert
            Assert.AreEqual(expected, canTimeout);
        }

        [TestCase(false)]
        [TestCase(true)]
        public void CanWrite_DelegatesToInnerStreamCanWrite(bool expected)
        {
            // Arrange
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock.Setup(s => s.CanWrite).Returns(expected);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            // Act
            bool canWrite = product.CanWrite;

            // Assert
            Assert.AreEqual(expected, canWrite);
        }

        [Test]
        public void Length_DelegatesToInnerStreamLength()
        {
            // Arrange
            long expected = 123;
            Mock<Stream> innerStreamMock = new Mock<Stream>(MockBehavior.Strict);
            innerStreamMock.Setup(s => s.Length).Returns(expected);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            // Act
            long length = product.Length;

            // Assert
            Assert.AreEqual(expected, length);
        }

        [Test]
        public void GetPosition_DelegatesToInnerStreamGetPosition()
        {
            // Arrange
            long expected = 123;
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock.Setup(s => s.Position).Returns(expected);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            // Act
            long position = product.Position;

            // Assert
            Assert.AreEqual(expected, position);
        }

        [Test]
        public void SetPosition_DelegatesToInnerStreamSetPosition()
        {
            // Arrange
            long expected = 123;
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock.SetupSet(s => s.Position = expected).Verifiable();
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            // Act
            product.Position = expected;

            // Assert
            innerStreamMock.Verify();
        }

        [Test]
        public void GetReadTimeout_DelegatesToInnerStreamGetReadTimeout()
        {
            // Arrange
            int expected = 123;
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock.Setup(s => s.ReadTimeout).Returns(expected);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            // Act
            int readTimeout = product.ReadTimeout;

            // Assert
            Assert.AreEqual(expected, readTimeout);
        }

        [Test]
        public void SetReadTimeout_DelegatesToInnerStreamSetReadTimeout()
        {
            // Arrange
            int expected = 123;
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock.SetupSet(s => s.ReadTimeout = expected).Verifiable();
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            // Act
            product.ReadTimeout = expected;

            // Assert
            innerStreamMock.Verify();
        }

        [Test]
        public void GetWriteTimeout_DelegatesToInnerStreamGetWriteTimeout()
        {
            // Arrange
            int expected = 123;
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock.Setup(s => s.WriteTimeout).Returns(expected);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            // Act
            int writeTimeout = product.WriteTimeout;

            // Assert
            Assert.AreEqual(expected, writeTimeout);
        }

        [Test]
        public void SetWriteTimeout_DelegatesToInnerStreamSetWriteTimeout()
        {
            // Arrange
            int expected = 123;
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock.SetupSet(s => s.WriteTimeout = expected).Verifiable();
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            // Act
            product.WriteTimeout = expected;

            // Assert
            innerStreamMock.Verify();
        }

        [Test]
        public void BeginRead_DelegatesToInnerStreamBeginRead()
        {
            // Arrange
            byte[] expectedBuffer = new byte[0];
            int expectedOffset = 123;
            int expectedCount = 456;

            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock
                .Setup(s => s.BeginRead(expectedBuffer, expectedOffset, expectedCount, It.IsAny<AsyncCallback>(),
                    It.IsAny<object>()))
                .ReturnsUncompleted()
                .Verifiable();
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            AsyncCallback callback = null;
            object state = null;

            // Act
            product.BeginRead(expectedBuffer, expectedOffset, expectedCount, callback, state);

            // Assert
            innerStreamMock.Verify();
        }

        [Test]
        public void BeginRead_WhenInnerStreamThrows_PropogatesException()
        {
            // Arrange
            Exception expectedException = new Exception();
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock
                .SetupBeginRead()
                .Throws(expectedException);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            byte[] buffer = new byte[0];
            int offset = 123;
            int count = 456;
            AsyncCallback callback = null;
            object state = null;

            // Act & Assert
            Exception exception = Assert.Throws<Exception>(() => product.BeginRead(buffer, offset, count, callback,
                state));
            Assert.AreSame(expectedException, exception);
        }

        [Test]
        public void BeginRead_WhenNotYetCompleted_ReturnsUncompletedResult()
        {
            // Arrange
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock
                .SetupBeginRead()
                .ReturnsUncompleted();
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            byte[] buffer = new byte[0];
            int offset = 123;
            int count = 456;
            AsyncCallback callback = null;
            object expectedState = new object();

            // Act
            IAsyncResult result = product.BeginRead(buffer, offset, count, callback, expectedState);

            // Assert
            ExpectedAsyncResult expectedResult = new ExpectedAsyncResult
            {
                AsyncState = expectedState,
                CompletedSynchronously = false,
                IsCompleted = false
            };
            AssertEqual(expectedResult, result, disposeActual: false);

            // Cleanup
            result.AsyncWaitHandle.Dispose();
        }

        [Test]
        public void BeginRead_WhenCompletedSynchronously_CallsCallbackAndReturnsCompletedResult()
        {
            // Arrange
            object expectedState = new object();
            ExpectedAsyncResult expectedResult = new ExpectedAsyncResult
            {
                AsyncState = expectedState,
                CompletedSynchronously = true,
                IsCompleted = true
            };

            bool callbackCalled = false;
            IAsyncResult callbackResult = null;
            Stream product = null;

            AsyncCallback callback = (ar) =>
            {
                callbackResult = ar;
                AssertEqual(expectedResult, ar);
                callbackCalled = true;
            };

            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock
                .SetupBeginRead()
                .ReturnsCompletedSynchronously();
            innerStreamMock
                .SetupEndRead()
                .Returns(-1);
            Stream innerStream = innerStreamMock.Object;
            product = CreateProductUnderTest(innerStream);

            byte[] buffer = new byte[0];
            int offset = 123;
            int count = 456;

            // Act
            IAsyncResult result = product.BeginRead(buffer, offset, count, callback, expectedState);

            // Assert
            Assert.True(callbackCalled);
            // An AsyncCallback must be called with the same IAsyncResult instance as the Begin method returned.
            Assert.AreSame(result, callbackResult);
            AssertEqual(expectedResult, result, disposeActual: true);
        }

        [Test]
        public void BeginRead_WhenCompletedAsynchronously_CallsCallbackAndCompletesResult()
        {
            // Arrange
            object expectedState = new object();
            ExpectedAsyncResult expectedResult = new ExpectedAsyncResult
            {
                AsyncState = expectedState,
                CompletedSynchronously = false,
                IsCompleted = true
            };

            bool callbackCalled = false;
            IAsyncResult callbackResult = null;
            Stream product = null;

            AsyncCallback callback = (ar) =>
            {
                callbackResult = ar;
                AssertEqual(expectedResult, ar);
                callbackCalled = true;
            };

            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            AsyncCompletionSource completion = new AsyncCompletionSource();
            innerStreamMock
                .SetupBeginRead()
                .ReturnsCompletingAsynchronously(completion);
            innerStreamMock
                .SetupEndRead()
                .Returns(-1);
            Stream innerStream = innerStreamMock.Object;
            product = CreateProductUnderTest(innerStream);

            byte[] buffer = new byte[0];
            int offset = 123;
            int count = 456;

            IAsyncResult result = product.BeginRead(buffer, offset, count, callback, expectedState);

            // Act
            completion.Complete();

            // Assert
            Assert.True(callbackCalled);
            // An AsyncCallback must be called with the same IAsyncResult instance as the Begin method returned.
            Assert.AreSame(result, callbackResult);
            AssertEqual(expectedResult, result, disposeActual: true);
        }

        [Test]
        public void EndRead_DelegatesToInnerStreamEndRead()
        {
            // Arrange
            int expectedBytesRead = 789;

            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            AsyncCompletionSource completion = new AsyncCompletionSource();
            innerStreamMock
                .SetupBeginRead()
                .ReturnsCompletingAsynchronously(completion);
            innerStreamMock
                .Setup(s => s.EndRead(It.Is<IAsyncResult>(ar => ar == completion.AsyncResult)))
                .Returns(expectedBytesRead)
                .Verifiable();
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            byte[] buffer = new byte[0];
            int offset = 123;
            int count = 456;
            AsyncCallback callback = null;
            object state = null;

            IAsyncResult result = product.BeginRead(buffer, offset, count, callback, state);
            completion.Complete();

            // Act
            int bytesRead = product.EndRead(result);

            // Assert
            Assert.AreEqual(expectedBytesRead, bytesRead);
            innerStreamMock.Verify();
        }

        [Test]
        public void EndRead_DuringCallback_DelegatesToInnerStreamEndRead()
        {
            // Arrange
            int expectedBytesRead = 789;

            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            AsyncCompletionSource completion = new AsyncCompletionSource();
            innerStreamMock
                .SetupBeginRead()
                .ReturnsCompletingAsynchronously(completion);
            innerStreamMock
                .Setup(s => s.EndRead(It.Is<IAsyncResult>(ar => ar == completion.AsyncResult)))
                .Returns(expectedBytesRead)
                .Verifiable();
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            byte[] buffer = new byte[0];
            int offset = 123;
            int count = 456;
            int bytesRead = 0;

            bool callbackCalled = false;
            AsyncCallback callback = (ar) =>
            {
                bytesRead = product.EndRead(ar);
                callbackCalled = true;
            };
            object state = null;

            IAsyncResult result = product.BeginRead(buffer, offset, count, callback, state);

            // Act
            completion.Complete();

            // Assert
            Assert.True(callbackCalled);
            Assert.AreEqual(expectedBytesRead, bytesRead);
            innerStreamMock.Verify();
        }

        [Test]
        public void EndRead_WhenInnerStreamThrows_PropogatesException()
        {
            // Arrange
            Exception expectedException = new Exception();
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            AsyncCompletionSource completion = new AsyncCompletionSource();
            innerStreamMock
                .SetupBeginRead()
                .ReturnsCompletingAsynchronously(completion);
            innerStreamMock
                .SetupEndRead()
                .Throws(expectedException);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            byte[] buffer = new byte[0];
            int offset = 123;
            int count = 456;
            AsyncCallback callback = null;
            object state = null;
            IAsyncResult result = product.BeginRead(buffer, offset, count, callback, state);
            completion.Complete();

            // Act & Assert
            Exception exception = Assert.Throws<Exception>(() => product.EndRead(result));
            Assert.AreSame(expectedException, exception);
        }

        [Test]
        public void BeginWrite_DelegatesToInnerStreamBeginWrite()
        {
            // Arrange
            byte[] expectedBuffer = new byte[0];
            int expectedOffset = 123;
            int expectedCount = 456;

            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock
                .Setup(s => s.BeginWrite(expectedBuffer, expectedOffset, expectedCount, It.IsAny<AsyncCallback>(),
                    It.IsAny<object>()))
                .ReturnsUncompleted()
                .Verifiable();
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            AsyncCallback callback = null;
            object state = null;

            // Act
            product.BeginWrite(expectedBuffer, expectedOffset, expectedCount, callback, state);

            // Assert
            innerStreamMock.Verify();
        }

        [Test]
        public void BeginWrite_WhenInnerStreamThrows_PropogatesException()
        {
            // Arrange
            Exception expectedException = new Exception();
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock
                .SetupBeginWrite()
                .Throws(expectedException);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            byte[] buffer = new byte[0];
            int offset = 123;
            int count = 456;
            AsyncCallback callback = null;
            object state = null;

            // Act & Assert
            Exception exception = Assert.Throws<Exception>(() => product.BeginWrite(buffer, offset, count, callback,
                state));
            Assert.AreSame(expectedException, exception);
        }

        [Test]
        public void BeginWrite_WhenNotYetCompleted_ReturnsUncompletedResult()
        {
            // Arrange
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock
                .SetupBeginWrite()
                .ReturnsUncompleted();
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            byte[] buffer = new byte[0];
            int offset = 123;
            int count = 456;
            AsyncCallback callback = null;
            object expectedState = new object();

            // Act
            IAsyncResult result = product.BeginWrite(buffer, offset, count, callback, expectedState);

            // Assert
            ExpectedAsyncResult expectedResult = new ExpectedAsyncResult
            {
                AsyncState = expectedState,
                CompletedSynchronously = false,
                IsCompleted = false
            };
            AssertEqual(expectedResult, result, disposeActual: false);

            // Cleanup
            result.AsyncWaitHandle.Dispose();
        }

        [Test]
        public void BeginWrite_WhenCompletedSynchronously_CallsCallbackAndReturnsCompletedResult()
        {
            // Arrange
            object expectedState = new object();
            ExpectedAsyncResult expectedResult = new ExpectedAsyncResult
            {
                AsyncState = expectedState,
                CompletedSynchronously = true,
                IsCompleted = true
            };

            bool callbackCalled = false;
            IAsyncResult callbackResult = null;
            Stream product = null;

            AsyncCallback callback = (ar) =>
            {
                callbackResult = ar;
                AssertEqual(expectedResult, ar);
                callbackCalled = true;
            };

            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock
                .SetupBeginWrite()
                .ReturnsCompletedSynchronously();
            innerStreamMock.SetupEndWrite();
            Stream innerStream = innerStreamMock.Object;
            product = CreateProductUnderTest(innerStream);

            byte[] buffer = new byte[0];
            int offset = 123;
            int count = 456;

            // Act
            IAsyncResult result = product.BeginWrite(buffer, offset, count, callback, expectedState);

            // Assert
            Assert.True(callbackCalled);
            // An AsyncCallback must be called with the same IAsyncResult instance as the Begin method returned.
            Assert.AreSame(result, callbackResult);
            AssertEqual(expectedResult, result, disposeActual: true);
        }

        [Test]
        public void BeginWrite_WhenCompletedAsynchronously_CallsCallbackAndCompletesResult()
        {
            // Arrange
            object expectedState = new object();
            ExpectedAsyncResult expectedResult = new ExpectedAsyncResult
            {
                AsyncState = expectedState,
                CompletedSynchronously = false,
                IsCompleted = true
            };

            bool callbackCalled = false;
            IAsyncResult callbackResult = null;
            Stream product = null;

            AsyncCallback callback = (ar) =>
            {
                callbackResult = ar;
                AssertEqual(expectedResult, ar);
                callbackCalled = true;
            };

            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            AsyncCompletionSource completion = new AsyncCompletionSource();
            innerStreamMock
                .SetupBeginWrite()
                .ReturnsCompletingAsynchronously(completion);
            innerStreamMock.SetupEndWrite();
            Stream innerStream = innerStreamMock.Object;
            product = CreateProductUnderTest(innerStream);

            byte[] buffer = new byte[0];
            int offset = 123;
            int count = 456;

            IAsyncResult result = product.BeginWrite(buffer, offset, count, callback, expectedState);

            // Act
            completion.Complete();

            // Assert
            Assert.True(callbackCalled);
            // An AsyncCallback must be called with the same IAsyncResult instance as the Begin method returned.
            Assert.AreSame(result, callbackResult);
            AssertEqual(expectedResult, result, disposeActual: true);
        }

        [Test]
        public void EndWrite_DelegatesToInnerStreamEndWrite()
        {
            // Arrange
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            AsyncCompletionSource completion = new AsyncCompletionSource();
            innerStreamMock
                .SetupBeginWrite()
                .ReturnsCompletingAsynchronously(completion);
            innerStreamMock
                .Setup(s => s.EndWrite(It.Is<IAsyncResult>((ar) => ar == completion.AsyncResult)))
                .Verifiable();
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            byte[] buffer = new byte[0];
            int offset = 123;
            int count = 456;
            AsyncCallback callback = null;
            object state = null;

            IAsyncResult result = product.BeginWrite(buffer, offset, count, callback, state);
            completion.Complete();

            // Act
            product.EndWrite(result);

            // Assert
            innerStreamMock.Verify();
        }

        [Test]
        public void EndWrite_DuringCallback_DelegatesToInnerStreamEndWrite()
        {
            // Arrange
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            AsyncCompletionSource completion = new AsyncCompletionSource();
            innerStreamMock
                .SetupBeginWrite()
                .ReturnsCompletingAsynchronously(completion);
            innerStreamMock
                .Setup(s => s.EndWrite(It.Is<IAsyncResult>((ar) => ar == completion.AsyncResult)))
                .Verifiable();
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            byte[] buffer = new byte[0];
            int offset = 123;
            int count = 456;

            bool callbackCalled = false;
            AsyncCallback callback = (ar) =>
            {
                product.EndWrite(ar);
                callbackCalled = true;
            };
            object state = null;

            IAsyncResult result = product.BeginWrite(buffer, offset, count, callback, state);

            // Act
            completion.Complete();

            // Assert
            Assert.True(callbackCalled);
            innerStreamMock.Verify();
        }

        [Test]
        public void EndWrite_WhenInnerStreamThrows_PropogatesException()
        {
            // Arrange
            Exception expectedException = new Exception();
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            AsyncCompletionSource completion = new AsyncCompletionSource();
            innerStreamMock
                .SetupBeginWrite()
                .ReturnsCompletingAsynchronously(completion);
            innerStreamMock
                .SetupEndWrite()
                .Throws(expectedException);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            byte[] buffer = new byte[0];
            int offset = 123;
            int count = 456;
            AsyncCallback callback = null;
            object state = null;
            IAsyncResult result = product.BeginWrite(buffer, offset, count, callback, state);
            completion.Complete();

            // Act & Assert
            Exception exception = Assert.Throws<Exception>(() => product.EndWrite(result));
            Assert.AreSame(expectedException, exception);
        }

        [Test]
        public void Close_DelegatesToInnerStreamClose()
        {
            // Arrange
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock
                .Setup(s => s.Close())
                .Verifiable();
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            // Act
            product.Close();

            // Assert
            innerStreamMock.Verify();
        }

        [Test]
        public void CopyToAsync_DelegatesToInnerStreamCopyToAsync()
        {
            // Arrange
            Stream expectedDestination = CreateDummyStream();
            int expectedBufferSize = 123;
            CancellationToken expectedCancellationToken = new CancellationToken(canceled: true);

            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock
                .Setup(s => s.CopyToAsync(expectedDestination, expectedBufferSize, expectedCancellationToken))
                .Returns(Task.FromResult(-1))
                .Verifiable();
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            // Act
            product.CopyToAsync(expectedDestination, expectedBufferSize, expectedCancellationToken);

            // Assert
            innerStreamMock.Verify();
        }

        [Test]
        public void CopyToAsync_WhenInnerStreamThrows_PropogatesException()
        {
            // Arrange
            Exception expectedException = new Exception();
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock
                .Setup(s => s.CopyToAsync(It.IsAny<Stream>(), It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Throws(expectedException);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            Stream destination = CreateDummyStream();
            int bufferSize = 123;
            CancellationToken cancellationToken = CancellationToken.None;

            // Act & Assert
            Exception exception = Assert.ThrowsAsync<Exception>(
                () => product.CopyToAsync(destination, bufferSize, cancellationToken));
            Assert.AreSame(expectedException, exception);
        }

        [Test]
        public void CopyToAsync_WhenInnerStreamHasNotYetCompleted_ReturnsIncompleteTask()
        {
            // Arrange
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            TaskCompletionSource<object> taskSource = new TaskCompletionSource<object>();
            innerStreamMock
                .Setup(s => s.CopyToAsync(It.IsAny<Stream>(), It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(taskSource.Task);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            Stream destination = CreateDummyStream();
            int bufferSize = 123;
            CancellationToken cancellationToken = CancellationToken.None;

            // Act
            Task task = product.CopyToAsync(destination, bufferSize, cancellationToken);

            // Assert
            Assert.NotNull(task);
            Assert.False(task.IsCompleted);
        }

        [Test]
        public void CopyToAsync_WhenInnerStreamHasCompleted_ReturnsRanToCompletionTask()
        {
            // Arrange
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            TaskCompletionSource<object> taskSource = new TaskCompletionSource<object>();
            taskSource.SetResult(null);
            innerStreamMock
                .Setup(s => s.CopyToAsync(It.IsAny<Stream>(), It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(taskSource.Task);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            Stream destination = CreateDummyStream();
            int bufferSize = 123;
            CancellationToken cancellationToken = CancellationToken.None;

            // Act
            Task task = product.CopyToAsync(destination, bufferSize, cancellationToken);

            // Assert
            Assert.NotNull(task);
            Assert.AreEqual(TaskStatus.RanToCompletion, task.Status);
        }

        [Test]
        public void CopyToAsync_WhenInnerStreamHasCanceled_ReturnsCanceledTask()
        {
            // Arrange
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            TaskCompletionSource<object> taskSource = new TaskCompletionSource<object>();
            taskSource.SetCanceled();
            innerStreamMock
                .Setup(s => s.CopyToAsync(It.IsAny<Stream>(), It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(taskSource.Task);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            Stream destination = CreateDummyStream();
            int bufferSize = 123;
            CancellationToken cancellationToken = CancellationToken.None;

            // Act
            Task task = product.CopyToAsync(destination, bufferSize, cancellationToken);

            // Assert
            Assert.NotNull(task);
            Assert.AreEqual(TaskStatus.Canceled, task.Status);
        }

        [Test]
        public void CopyToAsync_WhenInnerStreamHasFaulted_ReturnsFaultedTask()
        {
            // Arrange
            Exception expectedException = new Exception();
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            TaskCompletionSource<object> taskSource = new TaskCompletionSource<object>();
            taskSource.SetException(expectedException);
            innerStreamMock
                .Setup(s => s.CopyToAsync(It.IsAny<Stream>(), It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(taskSource.Task);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            Stream destination = CreateDummyStream();
            int bufferSize = 123;
            CancellationToken cancellationToken = CancellationToken.None;

            // Act
            Task task = product.CopyToAsync(destination, bufferSize, cancellationToken);

            // Assert
            Assert.NotNull(task);
            Assert.AreEqual(TaskStatus.Faulted, task.Status);
            Assert.NotNull(task.Exception);
            Assert.AreSame(expectedException, task.Exception.InnerException);
        }

        [Test]
        public void Flush_DelegatesToInnerStreamFlush()
        {
            // Arrange
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock
                .Setup(s => s.Flush())
                .Verifiable();
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            // Act
            product.Flush();

            // Assert
            innerStreamMock.Verify();
        }

        [Test]
        public void FlushAsync_DelegatesToInnerStreamFlushAsync()
        {
            // Arrange
            CancellationToken expectedCancellationToken = new CancellationToken(canceled: true);
            Task expectedTask = new Task(() => { });

            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock
                .Setup(s => s.FlushAsync(expectedCancellationToken))
                .Returns(expectedTask)
                .Verifiable();
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            // Act
            Task task = product.FlushAsync(expectedCancellationToken);

            // Assert
            Assert.AreSame(task, expectedTask);
            innerStreamMock.Verify();
        }

        [Test]
        public void Read_DelegatesToInnerStreamRead()
        {
            byte[] expectedBuffer = new byte[0];
            int expectedOffset = 123;
            int expectedCount = 456;
            int expectedBytesRead = 789;

            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock
                .Setup(s => s.Read(expectedBuffer, expectedOffset, expectedCount))
                .Returns(expectedBytesRead)
                .Verifiable();
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            // Act
            int bytesRead = product.Read(expectedBuffer, expectedOffset, expectedCount);

            // Assert
            Assert.AreEqual(expectedBytesRead, bytesRead);
            innerStreamMock.Verify();
        }

        [Test]
        public void ReadAsync_DelegatesToInnerStreamReadAsync()
        {
            // Arrange
            byte[] expectedBuffer = new byte[0];
            int expectedOffset = 123;
            int expectedCount = 456;
            CancellationToken expectedCancellationToken = new CancellationToken(canceled: true);

            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock
                .Setup(s => s.ReadAsync(expectedBuffer, expectedOffset, expectedCount, expectedCancellationToken))
                .Returns(Task.FromResult(-1))
                .Verifiable();
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            // Act
            product.ReadAsync(expectedBuffer, expectedOffset, expectedCount, expectedCancellationToken);

            // Assert
            innerStreamMock.Verify();
        }

        [Test]
        public void ReadAsync_WhenInnerStreamThrows_PropogatesException()
        {
            // Arrange
            Exception expectedException = new Exception();
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock
                .Setup(s => s.ReadAsync(It.IsAny<byte[]>(), It.IsAny<int>(), It.IsAny<int>(),
                    It.IsAny<CancellationToken>()))
                .Throws(expectedException);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            byte[] buffer = new byte[0];
            int offset = 123;
            int count = 456;
            CancellationToken cancellationToken = CancellationToken.None;

            // Act & Assert
            Exception exception = Assert.ThrowsAsync<Exception>(
                () => product.ReadAsync(buffer, offset, count, cancellationToken));
            Assert.AreSame(expectedException, exception);
        }

        [Test]
        public void ReadAsync_WhenInnerStreamHasNotYetCompleted_ReturnsIncompleteTask()
        {
            // Arrange
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            TaskCompletionSource<int> taskSource = new TaskCompletionSource<int>();
            innerStreamMock
                .Setup(s => s.ReadAsync(It.IsAny<byte[]>(), It.IsAny<int>(), It.IsAny<int>(),
                    It.IsAny<CancellationToken>()))
                .Returns(taskSource.Task);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            byte[] buffer = new byte[0];
            int offset = 123;
            int count = 456;
            CancellationToken cancellationToken = CancellationToken.None;

            // Act
            Task<int> task = product.ReadAsync(buffer, offset, count, cancellationToken);

            // Assert
            Assert.NotNull(task);
            Assert.False(task.IsCompleted);
        }

        [Test]
        public void ReadAsync_WhenInnerStreamHasCompleted_ReturnsRanToCompletionTask()
        {
            // Arrange
            int expectedBytesRead = 789;
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            TaskCompletionSource<int> taskSource = new TaskCompletionSource<int>();
            taskSource.SetResult(expectedBytesRead);
            innerStreamMock
                .Setup(s => s.ReadAsync(It.IsAny<byte[]>(), It.IsAny<int>(), It.IsAny<int>(),
                    It.IsAny<CancellationToken>()))
                .Returns(taskSource.Task);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            byte[] buffer = new byte[0];
            int offset = 123;
            int count = 456;
            CancellationToken cancellationToken = CancellationToken.None;

            // Act
            Task<int> task = product.ReadAsync(buffer, offset, count, cancellationToken);

            // Assert
            Assert.NotNull(task);
            Assert.AreEqual(TaskStatus.RanToCompletion, task.Status);
            Assert.AreEqual(expectedBytesRead, task.Result);
        }

        [Test]
        public void ReadAsync_WhenInnerStreamHasCanceled_ReturnsCanceledTask()
        {
            // Arrange
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            TaskCompletionSource<int> taskSource = new TaskCompletionSource<int>();
            taskSource.SetCanceled();
            innerStreamMock
                .Setup(s => s.ReadAsync(It.IsAny<byte[]>(), It.IsAny<int>(), It.IsAny<int>(),
                    It.IsAny<CancellationToken>()))
                .Returns(taskSource.Task);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            byte[] buffer = new byte[0];
            int offset = 123;
            int count = 456;
            CancellationToken cancellationToken = CancellationToken.None;

            // Act
            Task<int> task = product.ReadAsync(buffer, offset, count, cancellationToken);

            // Assert
            Assert.NotNull(task);
            Assert.AreEqual(TaskStatus.Canceled, task.Status);
        }

        [Test]
        public void ReadAsync_WhenInnerStreamHasFaulted_ReturnsFaultedTask()
        {
            // Arrange
            Exception expectedException = new Exception();
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            TaskCompletionSource<int> taskSource = new TaskCompletionSource<int>();
            taskSource.SetException(expectedException);
            innerStreamMock
                .Setup(s => s.ReadAsync(It.IsAny<byte[]>(), It.IsAny<int>(), It.IsAny<int>(),
                    It.IsAny<CancellationToken>()))
                .Returns(taskSource.Task);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            byte[] buffer = new byte[0];
            int offset = 123;
            int count = 456;
            CancellationToken cancellationToken = CancellationToken.None;

            // Act
            Task<int> task = product.ReadAsync(buffer, offset, count, cancellationToken);

            // Assert
            Assert.NotNull(task);
            Assert.AreEqual(TaskStatus.Faulted, task.Status);
            Assert.NotNull(task.Exception);
            Assert.AreSame(expectedException, task.Exception.InnerException);
        }

        [Test]
        public void ReadByte_DelegatesToInnerStreamReadByte()
        {
            // Arrange
            int expected = 123;
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock.Setup(s => s.ReadByte()).Returns(expected);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            // Act
            int actual = product.ReadByte();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Seek_DelegatesToInnerStreamSeek()
        {
            long expectedOffset = 123;
            SeekOrigin expectedOrigin = SeekOrigin.End;
            long expectedPosition = 456;

            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock
                .Setup(s => s.Seek(expectedOffset, expectedOrigin))
                .Returns(expectedPosition)
                .Verifiable();
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            // Act
            long position = product.Seek(expectedOffset, expectedOrigin);

            // Assert
            Assert.AreEqual(expectedPosition, position);
            innerStreamMock.Verify();
        }

        [Test]
        public void SetLength_DelegatesToInnerStreamSetLength()
        {
            long expectedValue = 123;

            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock
                .Setup(s => s.SetLength(expectedValue))
                .Verifiable();
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            // Act
            product.SetLength(expectedValue);

            // Assert
            innerStreamMock.Verify();
        }

        [Test]
        public void WriteDelegatesToInnerStreamWrite()
        {
            byte[] expectedBuffer = new byte[0];
            int expectedOffset = 123;
            int expectedCount = 456;

            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock
                .Setup(s => s.Write(expectedBuffer, expectedOffset, expectedCount))
                .Verifiable();
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            // Act
            product.Write(expectedBuffer, expectedOffset, expectedCount);

            // Assert
            innerStreamMock.Verify();
        }

        [Test]
        public void WriteAsync_DelegatesToInnerStreamWriteAsync()
        {
            // Arrange
            byte[] expectedBuffer = new byte[0];
            int expectedOffset = 123;
            int expectedCount = 456;
            CancellationToken expectedCancellationToken = new CancellationToken(canceled: true);

            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock
                .Setup(s => s.WriteAsync(expectedBuffer, expectedOffset, expectedCount, expectedCancellationToken))
                .Returns(Task.FromResult(-1))
                .Verifiable();
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            // Act
            product.WriteAsync(expectedBuffer, expectedOffset, expectedCount, expectedCancellationToken);

            // Assert
            innerStreamMock.Verify();
        }

        [Test]
        public void WriteAsync_WhenInnerStreamThrows_PropogatesException()
        {
            // Arrange
            Exception expectedException = new Exception();
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock
                .Setup(s => s.WriteAsync(It.IsAny<byte[]>(), It.IsAny<int>(), It.IsAny<int>(),
                    It.IsAny<CancellationToken>()))
                .Throws(expectedException);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            byte[] buffer = new byte[0];
            int offset = 123;
            int count = 456;
            CancellationToken cancellationToken = CancellationToken.None;

            // Act & Assert
            Exception exception = Assert.ThrowsAsync<Exception>(
                () => product.WriteAsync(buffer, offset, count, cancellationToken));
            Assert.AreSame(expectedException, exception);
        }

        [Test]
        public void WriteAsync_WhenInnerStreamHasNotYetCompleted_ReturnsIncompleteTask()
        {
            // Arrange
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            TaskCompletionSource<object> taskSource = new TaskCompletionSource<object>();
            innerStreamMock
                .Setup(s => s.WriteAsync(It.IsAny<byte[]>(), It.IsAny<int>(), It.IsAny<int>(),
                    It.IsAny<CancellationToken>()))
                .Returns(taskSource.Task);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            byte[] buffer = new byte[0];
            int offset = 123;
            int count = 456;
            CancellationToken cancellationToken = CancellationToken.None;

            // Act
            Task task = product.WriteAsync(buffer, offset, count, cancellationToken);

            // Assert
            Assert.NotNull(task);
            Assert.False(task.IsCompleted);
        }

        [Test]
        public void WriteAsync_WhenInnerStreamHasCompleted_ReturnsRanToCompletionTask()
        {
            // Arrange
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            TaskCompletionSource<object> taskSource = new TaskCompletionSource<object>();
            taskSource.SetResult(null);
            innerStreamMock
                .Setup(s => s.WriteAsync(It.IsAny<byte[]>(), It.IsAny<int>(), It.IsAny<int>(),
                    It.IsAny<CancellationToken>()))
                .Returns(taskSource.Task);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            byte[] buffer = new byte[0];
            int offset = 123;
            int count = 456;
            CancellationToken cancellationToken = CancellationToken.None;

            // Act
            Task task = product.WriteAsync(buffer, offset, count, cancellationToken);

            // Assert
            Assert.NotNull(task);
            Assert.AreEqual(TaskStatus.RanToCompletion, task.Status);
        }

        [Test]
        public void WriteAsync_WhenInnerStreamHasCanceled_ReturnsCanceledTask()
        {
            // Arrange
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            TaskCompletionSource<int> taskSource = new TaskCompletionSource<int>();
            taskSource.SetCanceled();
            innerStreamMock
                .Setup(s => s.WriteAsync(It.IsAny<byte[]>(), It.IsAny<int>(), It.IsAny<int>(),
                    It.IsAny<CancellationToken>()))
                .Returns(taskSource.Task);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            byte[] buffer = new byte[0];
            int offset = 123;
            int count = 456;
            CancellationToken cancellationToken = CancellationToken.None;

            // Act
            Task task = product.WriteAsync(buffer, offset, count, cancellationToken);

            // Assert
            Assert.NotNull(task);
            Assert.AreEqual(TaskStatus.Canceled, task.Status);
        }

        [Test]
        public void WriteAsync_WhenInnerStreamHasFaulted_ReturnsFaultedTask()
        {
            // Arrange
            Exception expectedException = new Exception();
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            TaskCompletionSource<int> taskSource = new TaskCompletionSource<int>();
            taskSource.SetException(expectedException);
            innerStreamMock
                .Setup(s => s.WriteAsync(It.IsAny<byte[]>(), It.IsAny<int>(), It.IsAny<int>(),
                    It.IsAny<CancellationToken>()))
                .Returns(taskSource.Task);
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            byte[] buffer = new byte[0];
            int offset = 123;
            int count = 456;
            CancellationToken cancellationToken = CancellationToken.None;

            // Act
            Task task = product.WriteAsync(buffer, offset, count, cancellationToken);

            // Assert
            Assert.NotNull(task);
            Assert.AreEqual(TaskStatus.Faulted, task.Status);
            Assert.NotNull(task.Exception);
            Assert.AreSame(expectedException, task.Exception.InnerException);
        }

        [Test]
        public void WriteByte_DelegatesToInnerStreamWriteByte()
        {
            // Arrange
            byte expected = 123;
            Mock<Stream> innerStreamMock = CreateMockInnerStream();
            innerStreamMock
                .Setup(s => s.WriteByte(expected))
                .Verifiable();
            Stream innerStream = innerStreamMock.Object;
            Stream product = CreateProductUnderTest(innerStream);

            // Act
            product.WriteByte(expected);

            // Assert
            innerStreamMock.Verify();
        }

        [Test]
        public void GetStatus_Initially_ReturnsZeroBytesRead()
        {
            // Arrange
            using (MemoryStream innerStream = CreateInnerStream(String.Empty))
            using (WatchableReadStream product = CreateProductUnderTest(innerStream))
            {
                // Act
                ParameterLog status = product.GetStatus();

                // Assert
                AssertEqualBytesRead(0, status);
            }
        }

        [Test]
        public void GetStatus_AfterRead_ReturnsBytesRead()
        {
            // Arrange
            string contents = "abc";

            using (MemoryStream innerStream = CreateInnerStream(contents))
            using (WatchableReadStream product = CreateProductUnderTest(innerStream))
            {
                byte[] buffer = new byte[contents.Length];
                int bytesRead = product.Read(buffer, 0, buffer.Length);
                Assert.AreEqual(bytesRead, buffer.Length); // Guard

                // Act
                ParameterLog status = product.GetStatus();

                // Assert
                AssertEqualBytesRead(contents.Length, status);
            }
        }

        [Test]
        public void GetStatus_AfterReadByte_ReturnsOneByteRead()
        {
            // Arrange
            string contents = "abc";

            using (MemoryStream innerStream = CreateInnerStream(contents))
            using (WatchableReadStream product = CreateProductUnderTest(innerStream))
            {
                int read = product.ReadByte();
                Assert.AreNotEqual(-1, read); // Guard

                // Act
                ParameterLog status = product.GetStatus();

                // Assert
                AssertEqualBytesRead(1, status);
            }
        }

        [Test]
        public void GetStatus_AfterReadByteTwice_ReturnsTwoBytesRead()
        {
            // Arrange
            string contents = "abc";

            using (MemoryStream innerStream = CreateInnerStream(contents))
            using (WatchableReadStream product = CreateProductUnderTest(innerStream))
            {
                int read = product.ReadByte();
                Assert.AreNotEqual(-1, read); // Guard
                read = product.ReadByte();
                Assert.AreNotEqual(-1, read); // Guard

                // Act
                ParameterLog status = product.GetStatus();

                // Assert
                AssertEqualBytesRead(2, status);
            }
        }

        [Test]
        public void GetStatus_AfterReadByteNegativeOne_ReturnsZeroBytesRead()
        {
            // Arrange
            string contents = String.Empty;

            using (MemoryStream innerStream = CreateInnerStream(contents))
            using (WatchableReadStream product = CreateProductUnderTest(innerStream))
            {
                int read = product.ReadByte();
                Assert.AreEqual(-1, read); // Guard

                // Act
                ParameterLog status = product.GetStatus();

                // Assert
                AssertEqualBytesRead(0, status);
            }
        }

        [Test]
        public async Task GetStatus_AfterReadAsync_ReturnsBytesRead()
        {
            // Arrange
            string contents = "abc";

            using (MemoryStream innerStream = CreateInnerStream(contents))
            using (WatchableReadStream product = CreateProductUnderTest(innerStream))
            {
                byte[] buffer = new byte[contents.Length];
                int bytesRead = await product.ReadAsync(buffer, 0, buffer.Length);
                Assert.AreEqual(bytesRead, buffer.Length); // Guard

                // Act
                ParameterLog status = product.GetStatus();

                // Assert
                AssertEqualBytesRead(contents.Length, status);
            }
        }

        [Test]
        public void GetStatus_AfterBeginEndRead_ReturnsBytesRead()
        {
            // Arrange
            string contents = "abc";

            using (MemoryStream innerStream = CreateInnerStream(contents))
            using (WatchableReadStream product = CreateProductUnderTest(innerStream))
            {
                byte[] buffer = new byte[contents.Length];
                int bytesRead = product.EndRead(product.BeginRead(buffer, 0, buffer.Length, null, null));
                Assert.AreEqual(bytesRead, buffer.Length); // Guard

                // Act
                ParameterLog status = product.GetStatus();

                // Assert
                AssertEqualBytesRead(contents.Length, status);
            }
        }

        [Test]
        public void GetStatus_AfterCopyToAsync_ReturnsAllBytesRead()
        {
            // Arrange
            string contents = "abc";

            using (MemoryStream innerStream = CreateInnerStream(contents))
            using (WatchableReadStream product = CreateProductUnderTest(innerStream))
            using (MemoryStream output = new MemoryStream())
            {
                product.CopyToAsync(output).GetAwaiter().GetResult();
                Assert.AreEqual(contents.Length, product.Position); // Guard

                // Act
                ParameterLog status = product.GetStatus();

                // Assert
                AssertEqualBytesRead(contents.Length, status);
            }
        }

        private static void AssertEqual(ExpectedAsyncResult expected, IAsyncResult actual,
            bool disposeActual = false)
        {
            Assert.NotNull(actual);
            Assert.AreSame(expected.AsyncState, actual.AsyncState);
            Assert.AreEqual(expected.CompletedSynchronously, actual.CompletedSynchronously);
            Assert.AreEqual(expected.IsCompleted, actual.IsCompleted);

            try
            {
                Assert.AreEqual(expected.IsCompleted, actual.AsyncWaitHandle.WaitOne(0));
            }
            finally
            {
                if (disposeActual)
                {
                    actual.Dispose();
                }
            }
        }

        private static void AssertEqualBytesRead(int expected, ParameterLog actual)
        {
            Assert.IsInstanceOf<ReadBlobParameterLog>(actual);
            ReadBlobParameterLog actualBlobLog = (ReadBlobParameterLog)actual;
            Assert.AreEqual(expected, actualBlobLog.BytesRead);
        }

        private static MemoryStream CreateInnerStream(string contents)
        {
            return new MemoryStream(Encoding.UTF8.GetBytes(contents), writable: false);
        }

        private static Stream CreateDummyStream()
        {
            return new Mock<Stream>(MockBehavior.Strict).Object;
        }

        private static Mock<Stream> CreateMockInnerStream()
        {
            Mock<Stream> mock = new Mock<Stream>(MockBehavior.Strict);
            mock.Setup(s => s.Length).Returns(0); // Used by WatchableReadStream constructor
            return mock;
        }

        private static WatchableReadStream CreateProductUnderTest(Stream inner)
        {
            return new WatchableReadStream(inner);
        }

        private struct ExpectedAsyncResult
        {
            public object AsyncState;
            public bool CompletedSynchronously;
            public bool IsCompleted;
        }
    }
}
