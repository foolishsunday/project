using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    public interface ICommand   //命令接口
    {
        string Execute();
    }
    //public class CommandChange : ICommand
    //{
    //    private Television m_tv;
    //    private int m_channel;
    //    public CommandChange(Television tv, int channel)
    //    {
    //        this.m_tv = tv;
    //        this.m_channel = channel;
    //    }
    //    public string Execute()
    //    {
    //        return m_tv.ChangeChannel(m_channel);
    //    }
    //}
    //public class CommandOff : ICommand
    //{
    //    private Television m_tv;
    //    public CommandOff(Television tv)
    //    {
    //        m_tv = tv;
    //    }
    //    public string Execute()
    //    {
    //        return m_tv.TrunOff();
    //    }

    //}
    //public class CommandOn : ICommand
    //{
    //    private Television m_tv;
    //    public CommandOn(Television tv)
    //    {
    //        m_tv = tv;
    //    }
    //    public string Execute()
    //    {
    //        return m_tv.TrunOn();
    //    }

    //}
  
}
