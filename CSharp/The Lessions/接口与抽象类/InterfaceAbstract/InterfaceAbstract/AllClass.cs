using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceAbstract
{
    /* 第3题：请定义一个TextQuestion类，继承自第2题中的QuestionBase；获取答案的方法返回字符串”文本答案”。
     * 再定义一个MultipleChoiceQuestion类，继承自第2题中的QuestionBase；获取答案的方法返回字符串”单选答案”
     */

    public class TextQuestion : QuestionBase
    {
        public override QuestionType QType
        {
            get { return QuestionType.Text; }
        }
        public override string GetAnswer()
        {
            return "文本答案";
        }

    }
}
