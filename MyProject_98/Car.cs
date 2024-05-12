using MyProject_99_MyLogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_99_Car
{
    public class Car
    {
        private const string ENGINE_IS_STARTED_MESSAGE = "Engine is started!";
        private const string ATTEMPT_TO_START_ENGINE_MESSAGE = "Attempt to start engine!";
        private const string ENGINE_HAS_ALREADY_STARTED_MESSAGE = "Engine has already started!";
        private const string ATTEMPT_TO_DRIVE_MESSAGE = "Attempt to drive!";
        private const string DRIVE_MESSAGE = "Let's go! Drive!";
        private const string DRIVE_ERROR_MESSAGE = "Engine isn't started!";

        private readonly MyLogger _myLogger;

        private bool isEngineStarted;

        public Car(MyLogger myLogger)
        {
            _myLogger = myLogger;
        }

        public void StartEngine()
        {
            _myLogger.Info(ATTEMPT_TO_START_ENGINE_MESSAGE);
            if(isEngineStarted)
            {
                _myLogger.Warn(ENGINE_HAS_ALREADY_STARTED_MESSAGE);
            }
            else
            {
                isEngineStarted = true;
                _myLogger.Info(ENGINE_IS_STARTED_MESSAGE);
            }
        }
        public void Drive()
        {
            _myLogger.Info(ATTEMPT_TO_DRIVE_MESSAGE);
            if(isEngineStarted)
            {
                _myLogger.Info(DRIVE_MESSAGE);
            }
            else
            {
                _myLogger.Error(DRIVE_ERROR_MESSAGE);
            }
        }
    }
}
