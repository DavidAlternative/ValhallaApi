using FluentValidation;
using Valhalla.Application.Requests;

namespace Valhalla.Application.Validators
{
    public class CreateFavoriteValidator : AbstractValidator<CreateFavoriteRequest>
    {
        public CreateFavoriteValidator()
        {

        }
    }
}
