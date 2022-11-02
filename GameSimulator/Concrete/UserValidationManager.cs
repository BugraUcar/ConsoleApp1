using GameSimulator.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulator.Concrete
{
    class UserValidationManager : IUserValidationService

    {
        public bool ValidationService()
        {
            return true;

        }
    }
}
