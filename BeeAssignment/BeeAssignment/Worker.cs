using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeAssignment
{
    class Worker
    {
        private string[] jobCanDo;
        private int shiftsToWork;
        private int shiftWorked;
        private string currentJob;

        public string CurrentJob { get { return currentJob; } }
        public int ShiftLeft { get { return shiftsToWork - shiftWorked; } }

        public bool DoThisJob(string job, int shift)
        {
            if (currentJob == "")
            {
                for (int i = 0; i < jobCanDo.Length; i++)
                    if (job == jobCanDo[i])
                    {
                        currentJob = job;
                        shiftsToWork = shift;
                        shiftWorked = 0;
                        return true;
                    }
            }
            return false;
        }
        public bool DidYouFinish()
        {
            if (currentJob == "")
                return false;
            shiftWorked++;
            if (this.ShiftLeft == 0)
            {
                currentJob = "";
                shiftsToWork = 0;
                shiftWorked = 0;
                return true;
            }
            return false;
        }

        public Worker(string[] jobCanDo)
        {
            this.jobCanDo = jobCanDo;
            currentJob = "";
        }
    }
}
