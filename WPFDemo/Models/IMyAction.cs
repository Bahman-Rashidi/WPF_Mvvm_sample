using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum ActionState
    {
        Done, Processing, New, Error
    }

    public enum ActionIconState
    {
        New, Processing, Done
    }
   public interface IMyAction
    {



        void doStep();

        void reset();
      //  Task<bool> doStep();

        //ActionIconState getActionIconState();


        //ActionState getActionState();
    }

   

    //public class  MyState
    //{



    //    void doStep();
    //    String getTitle();
    //    ActionIconState getActionIconState();


    //    ActionState getActionState();
    //}





}
