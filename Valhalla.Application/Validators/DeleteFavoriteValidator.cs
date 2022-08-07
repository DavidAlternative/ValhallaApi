using FluentValidation;
using Valhalla.Application.Requests;

namespace Valhalla.Application.Validators
{
    public class DeleteFavoriteValidator : AbstractValidator<DeleteFavoriteRequest>
    {
        public DeleteFavoriteValidator()
        {

        }
    }
}
