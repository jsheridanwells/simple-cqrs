using SimpleCQRS.Domain.Entities;

namespace SimpleCQRS.Domain.Commands.Command
{
   public interface ICommandHandler<in TCommand, out TResult>
      where TCommand : ICommand<TResult>
   {
      TResult Execute();
   } 
}