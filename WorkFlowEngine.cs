using System;
using System.Collections.Generic;

namespace OOP{
    interface IWorkFlow{
        void Execute();
    }
    public class VideoUploader : IWorkFlow{
        public void Execute(){

        }
    }
    public class CallWebService : IWorkFlow{
        public void Execute(){

        }
    }
    public class ChangeStatus : IWorkFlow{
        public void Execute(){

        }
    }
    public class SendEmail : IWorkFlow{
        public void Execute(){

        }
    }
    //Take A look below: NO access modifier for this class to access the interface. If you add access modifier, the methods lint errors.
    class WorkFlowEngine{
        private List<IWorkFlow> T =  new List<IWorkFlow>();
        public WorkFlowEngine(){}
        public void AddWorkFlowObject(IWorkFlow obj){
            T.Add(obj);
        }
        public void RemoveWorkFlowObject(IWorkFlow obj){
            T.Remove(obj);
        }
    }
}