using FluentValidation;
using Valhalla.Application.Requests;

namespace Valhalla.Application.Validators
{
    public class DeleteBrandValidator : AbstractValidator<DeleteBrandRequest>
    {
        public DeleteBrandValidator()
        {

        }
    }
}
