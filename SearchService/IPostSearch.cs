using System.Collections.Generic;

namespace SearchService
{
    interface IPostSearch
    {
        List<Post> SearchPosts(string searchKeyword);
    }
}
