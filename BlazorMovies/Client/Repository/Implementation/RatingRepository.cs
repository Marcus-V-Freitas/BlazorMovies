using BlazorMovies.Client.Helpers.Interface;
using BlazorMovies.Client.Repository.Interface;
using BlazorMovies.Shared.DTOs;
using System;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Repository.Implementation
{
    public class RatingRepository : IRatingRepository
    {
        private readonly IHttpService httpService;

        private readonly string urlBase = "api/rating";

        public RatingRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task Vote(MovieRatingDTO movieRating)
        {
            var httpResponse = await httpService.Post(urlBase, movieRating);

            if (!httpResponse.Success)
            {
                throw new ApplicationException(await httpResponse.GetBody());
            }
        }
    }
}