//
// CmisBaseTypeId.cs
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

namespace Cmis.Infrastructure
{
    /// <summary>
    /// CMIS base type identifier.
    /// </summary>
    public enum CmisBaseTypeId
    {
        /// <summary>
        /// CMIS document type.
        /// </summary>
        [CmisName(Constants.CmisDocument)]
        CmisDocument,

        /// <summary>
        /// CMIS folder type.
        /// </summary>
        [CmisName(Constants.CmisFolder)]
        CmisFolder,

        /// <summary>
        /// CMIS relationship type.
        /// </summary>
        [CmisName(Constants.CmisRelationship)]
        CmisRelationship,

        /// <summary>
        /// CMIS policy type.
        /// </summary>
        [CmisName(Constants.CmisPolicy)]
        CmisPolicy,

        /// <summary>
        /// CMIS item type.
        /// </summary>
        [CmisName(Constants.CmisItem)]
        CmisItem,

        /// <summary>
        /// CMIS secondary type.
        /// </summary>
        [CmisName(Constants.CmisSecondary)]
        CmisSecondary
    }
}
