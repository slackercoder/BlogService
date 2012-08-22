using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Data;

namespace BlogService
{
    public class BlogService : IBlogService
    {
        public List<BlogResponse> GetBlogs()
        {
            List<BlogResponse> responses = new List<BlogResponse>();

            using (BlogEntities data = new BlogEntities())
            {
                List<Blog> blogs = data.BlogPosts.ToList();

                foreach (Blog b in blogs)
                {
                    BlogResponse br = new BlogResponse();
                    br.Blogs.Add(new BlogObject(b.Id, b.Name));
                    br.Success = true;

                    responses.Add(br);
                }
            }

            return responses;
        }

        public BlogResponse GetBlogById(int id)
        {
            throw new NotImplementedException();
        }

        public BlogResponse CreateBlog(string blogName)
        {
            throw new NotImplementedException();
        }

        public BlogResponse CreateBlogPost(int blogId, string blogPostName)
        {
            throw new NotImplementedException();
        }

        public BlogResponse CreateBlogPostWithContent(int blogId, string blogPostName, string blogPostContent)
        {
            throw new NotImplementedException();
        }

        public BlogResponse AddPostToBlog(int blogId, string blogPostName, string blogPostContent)
        {
            throw new NotImplementedException();
        }
    }
}
