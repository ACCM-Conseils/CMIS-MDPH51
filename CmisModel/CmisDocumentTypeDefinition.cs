//
// CmisDocumentTypeDefinition.cs
//
// Author:
//       Dannys Janssen
//
// Copyright (c) 2017 Dannys Janssen
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using Cmis.Infrastructure;

namespace Cmis.Model
{
    /// <summary>
    /// CMIS document type definition. Document objects are the elementary information entities managed by the repository.
    /// </summary>
    public class CmisDocumentTypeDefinition : CmisTypeDefinitionBase, ICmisDocumentTypeDefinition
    {
		/// <summary>
		/// Can be acted upon via the Versioning Services (for example: checkOut, checkIn).
		/// </summary>
		/// <value><c>true</c> if versionable; otherwise, <c>false</c>.</value>
        public bool? Versionable { get; set; }

		/// <summary>
		/// Gets the content stream allowed.
		/// </summary>
		/// <value>The content stream allowed.</value>
        public CmisContentStreamAllowed? ContentStreamAllowed { get; set; }
    }
}