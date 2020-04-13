using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeAssignment
{
    class Queen
    {
        private Worker[] workers;
        private int shiftNumber = 0;

        public bool AssignWork(string workToDo, int shift)
        {
            for (int i = 0; i < 5; i++)
            {
                if (workers[i].DoThisJob(workToDo, shift))
                {
                    return true;
                }
            }
            return false;
        }
        public string WorkTheNextShift()
        {
            shiftNumber++;
            string report = "Report for shift #" + shiftNumber + "\r\n";
            for (int i = 0; i < 5; i++)
            {
                if (workers[i].DidYouFinish() == true)
                    report += "Worker #" + (i + 1) + " finished the job\r\n";
                else if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Worker #" + (i + 1) + " is not working\r\n";
                else
                {
                    if (workers[i].ShiftLeft == 1)
                        report += "Worker #" + (i + 1) + " will be done with \'" + workers[i].CurrentJob + "\' after this shift\r\n";
                    else
                    {
                        report += "Worker #" + (i + 1) + " is doing \'" + workers[i].CurrentJob + "\' for more " + workers[i].ShiftLeft + "\r\n";
                    }
                }
            }
            return report;
        }

        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }
    }
}
