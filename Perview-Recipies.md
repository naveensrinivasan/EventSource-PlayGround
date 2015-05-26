# Perfview Tips #

### Recipies

#### I want the ETW traces to keep tracing but stop when an Operation takes more than certain duration####

- Implement Start and Stop ETW Tracing operation in `EventSource`



        [Event(1, Keywords = Keywords.Requests, Task = Tasks.Request,   
		Opcode=EventOpcode.Start)]
        public void RequestStart(int RequestID, string Url)  
		 { WriteEvent(1, RequestID, Url); }  

   
        [Event(2, Keywords = Keywords.Requests,  
		 Task = Tasks.Request, Opcode=EventOpcode.Stop)]
        public void RequestStop(int RequestID) { WriteEvent(2, RequestID); }


- Then to trace a Request that took more than 2 seconds.  `PerfView /StopOnEtwEvent:*Samples-EventSourceDemos-Customized/Request/Start;TriggerMSec=2000 collect `
 

