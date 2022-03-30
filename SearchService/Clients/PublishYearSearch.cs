using System;
using System.Collections.Generic;

namespace SearchService.Clients
{
    class PublishYearSearch : IPostSearch
    {
        public List<Post> SearchPosts(string searchKeyword)
        {
            return new SearchService().Search(
                (post) => {
                    return post.PublishDate.Year == Convert.ToInt32(searchKeyword);
                });
        }
    }
}
