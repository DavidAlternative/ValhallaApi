using FluentValidation;
using Valhalla.Application.Requests;

namespace Valhalla.Application.Validators
{
    public class CreateOrderValidator : AbstractValidator<CreateOrderRequest>
    {
        public CreateOrderValidator()
        {

        }
    }
}
