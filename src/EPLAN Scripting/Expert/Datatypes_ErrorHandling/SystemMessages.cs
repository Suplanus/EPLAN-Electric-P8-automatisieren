using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class SystemMessages
{
  [Start]
  public void Function()
  {
    new BaseException("Message", MessageLevel.FatalError).FixMessage();
    new BaseException("Message", MessageLevel.Error).FixMessage();
    new BaseException("Message", MessageLevel.Warning).FixMessage();
    new BaseException("Message", MessageLevel.Message).FixMessage();
  }
}