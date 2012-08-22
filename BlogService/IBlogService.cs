using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BlogService
{
    [ServiceContract]
    public interface IBlogService
    {
        [OperationContract]
        public List<BlogResponse> GetBlogs();

        [OperationContract]
        public BlogResponse GetBlogById(int id);

        [OperationContract]
        public BlogResponse CreateBlog(String blogName);

        [OperationContract]
        public BlogResponse CreateBlogPost(int blogId, String blogPostName);

        [OperationContract]
        public BlogResponse CreateBlogPostWithContent(int blogId, String blogPostName, String blogPostContent);

        [OperationContract]
        public BlogResponse AddPostToBlog(int blogId, String blogPostName, String blogPostContent);
    }
}
