﻿namespace dotless.Core.Parser.Functions
{
    using Infrastructure.Nodes;
    using Tree;
    using Utils;

    public class RgbFunction : RgbaFunction
  {
    protected override Node Evaluate()
    {
      Guard.ExpectNumArguments(3, Arguments.Count, this);

      Arguments.Add(new Number(1d, ""));

      return base.Evaluate();
    }
  }
}