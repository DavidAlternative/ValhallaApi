using FluentValidation;
using Valhalla.Application.Requests;

namespace Valhalla.Application.Validators
{
    public class DeleteOrderValidator : AbstractValidator<DeleteOrderRequest>
    {
        public DeleteOrderValidator()
        {

        }
    }
}
