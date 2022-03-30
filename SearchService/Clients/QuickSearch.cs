using System.Collections.Generic;

namespace SearchService.Clients
{
    class QuickSearch : IPostSearch
    {
        public List<Post> SearchPosts(string searchKeyword)
        {
            return new SearchService().Search(
                (post) => {
                    return post.Title.ToLower().Contains(searchKeyword.ToLower());
                });
        }
    }
}