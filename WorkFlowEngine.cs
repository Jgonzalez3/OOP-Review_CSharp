using System;
using System.Collections.Generic;

namespace OOP{
    public interface ITask{
        void Execute();
    }
    public interface IWorkFlow{
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
    }
    public class WorkFlow : IWorkFlow{
        private readonly List<ITask> _tasks;
        public WorkFlow(){
            _tasks = new List<ITask>();
        }
        public void Add(ITask task){
            _tasks.Add(task);
        }
        public void Remove(ITask task){
            _tasks.Remove(task);
        }
        // IEnumerable needed to prevent exposing private readonly List from this class.
        public IEnumerable<ITask> GetTasks(){
            return _tasks;
        }
    }
    public class VideoUploader : ITask{
        public void Execute(){
        }
    }
    public class CallWebService : ITask{
        public void Execute(){
        }
    }
    public class ChangeStatus : ITask{
        public void Execute(){

        }
    }
    public class SendEmail : ITask{
        public void Execute(){

        }
    }
    //Take A look below: Access modifier of class must match access modifier of the interface using if not implemented by class, if none don't use any.
    public class WorkFlowEngine{
        public void Run(IWorkFlow workFlow{
            foreach(ITask I in workFlow.GetTasks()){
                try{
                    I.Execute();
                }
                catch (Exception){
                    // Logging
                    // Terminate WorkFlow and persist state of workflow
                    throw;
                }
            }
        }
    }
}