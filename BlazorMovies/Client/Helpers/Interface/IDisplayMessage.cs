using System.Threading.Tasks;

namespace BlazorMovies.Client.Helpers.Interface
{
    public interface IDisplayMessage
    {
        ValueTask DisplayErrorMessage(string message);

        ValueTask DisplaySuccessMessage(string message);
    }
}