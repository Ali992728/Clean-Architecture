using MediatR;
using MyAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAPI.Application.Commands.EmployeeCommands
{
    public record DeleteEmployeeCommand(int id) : IRequest<string>;

    public class DeleteEmployeeCommandHandler(IEmployeeRepository repository) : IRequestHandler<DeleteEmployeeCommand, string>
    {
        public Task<string> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            return repository.DeleteEmployeeAsync(request.id);
        }
    }
}
