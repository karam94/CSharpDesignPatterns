namespace Facade_Pattern.WorkerClasses
{
    public class Facade
    {
        private readonly ServiceClassA _serviceClassA;
        private readonly ServiceClassB _serviceClassB;
        private readonly ServiceClassC _serviceClassC;
        private readonly ServiceClassD _serviceClassD;

        public Facade()
        {
            _serviceClassA = new ServiceClassA();
            _serviceClassB = new ServiceClassB();
            _serviceClassC = new ServiceClassC();
            _serviceClassD = new ServiceClassD();
        }

        public string PrintAbcd()
        {
            var toReturn = "";
            toReturn += _serviceClassA.SayA;
            toReturn += _serviceClassB.SayB;
            toReturn += _serviceClassC.SayC;
            toReturn += _serviceClassD.SayD;

            return toReturn;
        }
    }
}
