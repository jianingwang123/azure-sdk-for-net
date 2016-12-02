// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// FileSystemOperations operations.
    /// </summary>
    public partial interface IFileSystemOperations
    {
        /// <summary>
        /// Appends to the specified file. This method supports multiple
        /// concurrent appends to the file. NOTE: ConcurrentAppend and normal
        /// (serial) Append CANNOT be used interchangeably; once a file has
        /// been appended to using either of these append options, it can
        /// only be appended to using that append option. ConcurrentAppend
        /// DOES NOT guarantee order and can result in duplicated data
        /// landing in the target file.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Store account to execute filesystem operations
        /// on.
        /// </param>
        /// <param name='filePath'>
        /// The Data Lake Store path (starting with '/') of the file to which
        /// to append using concurrent append.
        /// </param>
        /// <param name='streamContents'>
        /// The file contents to include when appending to the file.
        /// </param>
        /// <param name='appendMode'>
        /// Indicates the concurrent append call should create the file if it
        /// doesn't exist or just open the existing file for append. Possible
        /// values include: 'autocreate'
        /// </param>
        /// <param name='syncFlag'>
        /// Optionally indicates what to do after completion of the concurrent
        /// append. DATA indicates more data is coming so no sync takes
        /// place, METADATA indicates a sync should be done to refresh
        /// metadata of the file only. CLOSE indicates that both the stream
        /// and metadata should be refreshed upon append completion. Possible
        /// values include: 'DATA', 'METADATA', 'CLOSE'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AdlsErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> ConcurrentAppendWithHttpMessagesAsync(string accountName, string filePath, System.IO.Stream streamContents, AppendModeType? appendMode = default(AppendModeType?), SyncFlag? syncFlag = default(SyncFlag?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Sets or removes the expiration time on the specified file. This
        /// operation can only be executed against files. Folders are not
        /// supported.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Store account to execute filesystem operations
        /// on.
        /// </param>
        /// <param name='filePath'>
        /// The Data Lake Store path (starting with '/') of the file on which
        /// to set or remove the expiration time.
        /// </param>
        /// <param name='expiryOption'>
        /// Indicates the type of expiration to use for the file: 1.
        /// NeverExpire: ExpireTime is ignored. 2. RelativeToNow: ExpireTime
        /// is an integer in milliseconds representing the expiration date
        /// relative to when file expiration is updated. 3.
        /// RelativeToCreationDate: ExpireTime is an integer in milliseconds
        /// representing the expiration date relative to file creation. 4.
        /// Absolute: ExpireTime is an integer in milliseconds, as a Unix
        /// timestamp relative to 1/1/1970 00:00:00. Possible values include:
        /// 'NeverExpire', 'RelativeToNow', 'RelativeToCreationDate',
        /// 'Absolute'
        /// </param>
        /// <param name='expireTime'>
        /// The time that the file will expire, corresponding to the
        /// ExpiryOption that was set.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AdlsErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> SetFileExpiryWithHttpMessagesAsync(string accountName, string filePath, ExpiryOptionType expiryOption, long? expireTime = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Checks if the specified access is available at the given path.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Store account to execute filesystem operations
        /// on.
        /// </param>
        /// <param name='path'>
        /// The Data Lake Store path (starting with '/') of the file or
        /// directory for which to check access.
        /// </param>
        /// <param name='fsaction'>
        /// File system operation read/write/execute in string form, matching
        /// regex pattern '[rwx-]{3}'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AdlsErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> CheckAccessWithHttpMessagesAsync(string accountName, string path, string fsaction = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a directory.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Store account to execute filesystem operations
        /// on.
        /// </param>
        /// <param name='path'>
        /// The Data Lake Store path (starting with '/') of the directory to
        /// create.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AdlsErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<FileOperationResult>> MkdirsWithHttpMessagesAsync(string accountName, string path, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Concatenates the list of source files into the destination file,
        /// removing all source files upon success.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Store account to execute filesystem operations
        /// on.
        /// </param>
        /// <param name='destinationPath'>
        /// The Data Lake Store path (starting with '/') of the destination
        /// file resulting from the concatenation.
        /// </param>
        /// <param name='sources'>
        /// A list of comma seperated Data Lake Store paths (starting with
        /// '/') of the files to concatenate, in the order in which they
        /// should be concatenated.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AdlsErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> ConcatWithHttpMessagesAsync(string accountName, string destinationPath, IList<string> sources, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Concatenates the list of source files into the destination file,
        /// deleting all source files upon success. This method accepts more
        /// source file paths than the Concat method. This method and the
        /// parameters it accepts are subject to change for usability in an
        /// upcoming version.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Store account to execute filesystem operations
        /// on.
        /// </param>
        /// <param name='msConcatDestinationPath'>
        /// The Data Lake Store path (starting with '/') of the destination
        /// file resulting from the concatenation.
        /// </param>
        /// <param name='streamContents'>
        /// A list of Data Lake Store paths (starting with '/') of the source
        /// files. Must be in the format: sources=&lt;comma separated list&gt;
        /// </param>
        /// <param name='deleteSourceDirectory'>
        /// Indicates that as an optimization instead of deleting each
        /// individual source stream, delete the source stream folder if all
        /// streams are in the same folder instead. This results in a
        /// substantial performance improvement when the only streams in the
        /// folder are part of the concatenation operation. WARNING: This
        /// includes the deletion of any other files that are not source
        /// files. Only set this to true when source files are the only files
        /// in the source directory.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AdlsErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> MsConcatWithHttpMessagesAsync(string accountName, string msConcatDestinationPath, System.IO.Stream streamContents, bool? deleteSourceDirectory = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the list of file status objects specified by the file path,
        /// with optional pagination parameters
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Store account to execute filesystem operations
        /// on.
        /// </param>
        /// <param name='listFilePath'>
        /// The Data Lake Store path (starting with '/') of the directory to
        /// list.
        /// </param>
        /// <param name='listSize'>
        /// Gets or sets the number of items to return. Optional.
        /// </param>
        /// <param name='listAfter'>
        /// Gets or sets the item or lexographical index after which to begin
        /// returning results. For example, a file list of 'a','b','d' and
        /// listAfter='b' will return 'd', and a listAfter='c' will also
        /// return 'd'. Optional.
        /// </param>
        /// <param name='listBefore'>
        /// Gets or sets the item or lexographical index before which to begin
        /// returning results. For example, a file list of 'a','b','d' and
        /// listBefore='d' will return 'a','b', and a listBefore='c' will
        /// also return 'a','b'. Optional.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AdlsErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<FileStatusesResult>> ListFileStatusWithHttpMessagesAsync(string accountName, string listFilePath, int? listSize = default(int?), string listAfter = default(string), string listBefore = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the file content summary object specified by the file path.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Store account to execute filesystem operations
        /// on.
        /// </param>
        /// <param name='getContentSummaryFilePath'>
        /// The Data Lake Store path (starting with '/') of the file for which
        /// to retrieve the summary.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AdlsErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ContentSummaryResult>> GetContentSummaryWithHttpMessagesAsync(string accountName, string getContentSummaryFilePath, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the file status object specified by the file path.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Store account to execute filesystem operations
        /// on.
        /// </param>
        /// <param name='getFilePath'>
        /// The Data Lake Store path (starting with '/') of the file or
        /// directory for which to retrieve the status.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AdlsErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<FileStatusResult>> GetFileStatusWithHttpMessagesAsync(string accountName, string getFilePath, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Appends to the specified file. This method does not support
        /// multiple concurrent appends to the file. NOTE: Concurrent append
        /// and normal (serial) append CANNOT be used interchangeably. Once a
        /// file has been appended to using either append option, it can only
        /// be appended to using that append option. Use the ConcurrentAppend
        /// option if you would like support for concurrent appends.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Store account to execute filesystem operations
        /// on.
        /// </param>
        /// <param name='directFilePath'>
        /// The Data Lake Store path (starting with '/') of the file to which
        /// to append.
        /// </param>
        /// <param name='streamContents'>
        /// The file contents to include when appending to the file.
        /// </param>
        /// <param name='offset'>
        /// The optional offset in the stream to begin the append operation.
        /// Default is to append at the end of the stream.
        /// </param>
        /// <param name='syncFlag'>
        /// Optionally indicates what to do after completion of the append.
        /// DATA indicates more data is coming so no sync takes place,
        /// METADATA indicates a sync should be done to refresh metadata of
        /// the file only. CLOSE indicates that both the stream and metadata
        /// should be refreshed upon append completion. Possible values
        /// include: 'DATA', 'METADATA', 'CLOSE'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AdlsErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> AppendWithHttpMessagesAsync(string accountName, string directFilePath, System.IO.Stream streamContents, long? offset = default(long?), SyncFlag? syncFlag = default(SyncFlag?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a file with optionally specified content.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Store account to execute filesystem operations
        /// on.
        /// </param>
        /// <param name='directFilePath'>
        /// The Data Lake Store path (starting with '/') of the file to create.
        /// </param>
        /// <param name='streamContents'>
        /// The file contents to include when creating the file. This
        /// parameter is optional, resulting in an empty file if not
        /// specified.
        /// </param>
        /// <param name='overwrite'>
        /// The indication of if the file should be overwritten.
        /// </param>
        /// <param name='syncFlag'>
        /// Optionally indicates what to do after completion of the append.
        /// DATA indicates more data is coming so no sync takes place,
        /// METADATA indicates a sync should be done to refresh metadata of
        /// the file only. CLOSE indicates that both the stream and metadata
        /// should be refreshed upon append completion. Possible values
        /// include: 'DATA', 'METADATA', 'CLOSE'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AdlsErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> CreateWithHttpMessagesAsync(string accountName, string directFilePath, System.IO.Stream streamContents = default(System.IO.Stream), bool? overwrite = default(bool?), SyncFlag? syncFlag = default(SyncFlag?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Opens and reads from the specified file.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Store account to execute filesystem operations
        /// on.
        /// </param>
        /// <param name='directFilePath'>
        /// The Data Lake Store path (starting with '/') of the file to open.
        /// </param>
        /// <param name='length'>
        /// The number of bytes that the server will attempt to retrieve. It
        /// will retrieve &lt;= length bytes.
        /// </param>
        /// <param name='offset'>
        /// The byte offset to start reading data from.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<System.IO.Stream>> OpenWithHttpMessagesAsync(string accountName, string directFilePath, long? length = default(long?), long? offset = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Sets the Access Control List (ACL) for a file or folder.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Store account to execute filesystem operations
        /// on.
        /// </param>
        /// <param name='setAclFilePath'>
        /// The Data Lake Store path (starting with '/') of the file or
        /// directory on which to set the ACL.
        /// </param>
        /// <param name='aclspec'>
        /// The ACL spec included in ACL creation operations in the format
        /// '[default:]user|group|other::r|-w|-x|-'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AdlsErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> SetAclWithHttpMessagesAsync(string accountName, string setAclFilePath, string aclspec, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Modifies existing Access Control List (ACL) entries on a file or
        /// folder.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Store account to execute filesystem operations
        /// on.
        /// </param>
        /// <param name='modifyAclFilePath'>
        /// The Data Lake Store path (starting with '/') of the file or
        /// directory with the ACL being modified.
        /// </param>
        /// <param name='aclspec'>
        /// The ACL specification included in ACL modification operations in
        /// the format '[default:]user|group|other::r|-w|-x|-'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AdlsErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> ModifyAclEntriesWithHttpMessagesAsync(string accountName, string modifyAclFilePath, string aclspec, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Removes existing Access Control List (ACL) entries for a file or
        /// folder.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Store account to execute filesystem operations
        /// on.
        /// </param>
        /// <param name='removeAclFilePath'>
        /// The Data Lake Store path (starting with '/') of the file or
        /// directory with the ACL being removed.
        /// </param>
        /// <param name='aclspec'>
        /// The ACL spec included in ACL removal operations in the format
        /// '[default:]user|group|other'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AdlsErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> RemoveAclEntriesWithHttpMessagesAsync(string accountName, string removeAclFilePath, string aclspec, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Removes the existing Default Access Control List (ACL) of the
        /// specified directory.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Store account to execute filesystem operations
        /// on.
        /// </param>
        /// <param name='defaultAclFilePath'>
        /// The Data Lake Store path (starting with '/') of the directory with
        /// the default ACL being removed.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AdlsErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> RemoveDefaultAclWithHttpMessagesAsync(string accountName, string defaultAclFilePath, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Removes the existing Access Control List (ACL) of the specified
        /// file or directory.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Store account to execute filesystem operations
        /// on.
        /// </param>
        /// <param name='aclFilePath'>
        /// The Data Lake Store path (starting with '/') of the file or
        /// directory with the ACL being removed.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AdlsErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> RemoveAclWithHttpMessagesAsync(string accountName, string aclFilePath, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets Access Control List (ACL) entries for the specified file or
        /// directory.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Store account to execute filesystem operations
        /// on.
        /// </param>
        /// <param name='aclFilePath'>
        /// The Data Lake Store path (starting with '/') of the file or
        /// directory for which to get the ACL.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AdlsErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AclStatusResult>> GetAclStatusWithHttpMessagesAsync(string accountName, string aclFilePath, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the requested file or directory, optionally recursively.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Store account to execute filesystem operations
        /// on.
        /// </param>
        /// <param name='filePath'>
        /// The Data Lake Store path (starting with '/') of the file or
        /// directory to delete.
        /// </param>
        /// <param name='recursive'>
        /// The optional switch indicating if the delete should be recursive
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AdlsErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<FileOperationResult>> DeleteWithHttpMessagesAsync(string accountName, string filePath, bool? recursive = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Rename a file or directory.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Store account to execute filesystem operations
        /// on.
        /// </param>
        /// <param name='renameFilePath'>
        /// The Data Lake Store path (starting with '/') of the file or
        /// directory to move/rename.
        /// </param>
        /// <param name='destination'>
        /// The path to move/rename the file or folder to
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AdlsErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<FileOperationResult>> RenameWithHttpMessagesAsync(string accountName, string renameFilePath, string destination, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Sets the owner of a file or directory.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Store account to execute filesystem operations
        /// on.
        /// </param>
        /// <param name='setOwnerFilePath'>
        /// The Data Lake Store path (starting with '/') of the file or
        /// directory for which to set the owner.
        /// </param>
        /// <param name='owner'>
        /// The AAD Object ID of the user owner of the file or directory. If
        /// empty, the property will remain unchanged.
        /// </param>
        /// <param name='group'>
        /// The AAD Object ID of the group owner of the file or directory. If
        /// empty, the property will remain unchanged.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AdlsErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> SetOwnerWithHttpMessagesAsync(string accountName, string setOwnerFilePath, string owner = default(string), string group = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Sets the permission of the file or folder.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Store account to execute filesystem operations
        /// on.
        /// </param>
        /// <param name='setPermissionFilePath'>
        /// The Data Lake Store path (starting with '/') of the file or
        /// directory for which to set the permission.
        /// </param>
        /// <param name='permission'>
        /// A string representation of the permission (i.e 'rwx'). If empty,
        /// this property remains unchanged.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AdlsErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> SetPermissionWithHttpMessagesAsync(string accountName, string setPermissionFilePath, string permission = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
