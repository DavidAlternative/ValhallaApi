using FluentValidation;
using Valhalla.Application.Requests;

namespace Valhalla.Application.Validators
{
    public class UpdateUserValidator : AbstractValidator<UpdateUserRequest>
    {
        public UpdateUserValidator()
        {

        }
    }
}
