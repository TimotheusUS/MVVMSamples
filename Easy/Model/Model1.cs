using System;
using System.Threading;

namespace TimotheusUS.MVVMsamples.Easy
{
 public class Model1
 {
  public string ConvertText(string inputText) => inputText?.ToUpper();
 }
}
