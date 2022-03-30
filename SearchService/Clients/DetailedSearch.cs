using System.Collections.Generic;

namespace SearchService.Clients
{
    class DetailedSearch : IPostSearch
    {
        public List<Post> SearchPosts(string searchKeyword)
        {
            return new SearchService().Search(
                (post) => {
                    return post.Title.ToLower().Contains(searchKeyword.ToLower()) ||
                    post.Content.ToLower().Contains(searchKeyword.ToLower());
                });
        }
    }
}
