
using System;
using System.Collections.Generic;
using System.Text;

namespace Alphaleonis.Win32.Vss
{
   /// <summary>
   /// Exception indicating that the writer ran out of memory or other system resources. 
   /// The recommended way to handle this error code is to wait ten minutes and then repeat the operation, up to three times.
   /// </summary>
   [Serializable]
   public class VssOutOfResourcesWriterException : VssRetryableWriterException
   {
      /// <summary>
      /// Initializes a new instance of the <see cref="VssOutOfResourcesWriterException"/> class.
      /// </summary>
      public VssOutOfResourcesWriterException()
         : base(Alphaleonis.Win32.Vss.Resources.LocalizedStrings.VssOutOfResourcesExceptionMessage)
      {
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="VssOutOfResourcesWriterException"/> class.
      /// </summary>
      /// <param name="message">The message that describes the error</param>
      public VssOutOfResourcesWriterException(string message) : base(message) { }

      /// <summary>
      /// Initializes a new instance of the <see cref="VssOutOfResourcesWriterException"/> class.
      /// </summary>
      /// <param name="message">The message that describes the error</param>
      /// <param name="innerException">The exception that is the cause of the current exception.</param>
      public VssOutOfResourcesWriterException(string message, Exception innerException) : base(message, innerException) { }

      /// <summary>
      /// Initializes a new instance of the <see cref="VssOutOfResourcesWriterException"/> class.
      /// </summary>
      /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
      /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"/> that contains contextual information about the source or destination.</param>
      /// <exception cref="T:System.ArgumentNullException">
      /// The <paramref name="info"/> parameter is <see langword="null"/>.
      /// </exception>
      /// <exception cref="T:System.Runtime.Serialization.SerializationException">
      /// The class name is <see langword="null"/> or <see cref="P:System.Exception.HResult"/> is zero (0).
      /// </exception>
      protected VssOutOfResourcesWriterException(
       System.Runtime.Serialization.SerializationInfo info,
       System.Runtime.Serialization.StreamingContext context)
         : base(info, context) { }
   }
}

