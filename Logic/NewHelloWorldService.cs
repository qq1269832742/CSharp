using ILogics;

namespace IRepository
{
    public class HelloWorldLogic : IHelloWorldLogic
    {
        private readonly IHelloWorldRepository _helloWorldRepository;
        public HelloWorldLogic(IHelloWorldRepository helloWorldRepository)
        {
            _helloWorldRepository = helloWorldRepository;
        }
        public string SayHello(string name)
        {
            return "Hello " + name;
        }
        public string SayHelloById(string id)
        {
            return _helloWorldRepository.GetUserName(id);
        }
    }
}