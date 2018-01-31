// **********************************************************************
//
// Copyright (c) 2003-2018 ZeroC, Inc. All rights reserved.
//
// **********************************************************************

using Demo;

public sealed class CallbackReceiverI : CallbackReceiverDisp_
{
    public override void callback(int num, Ice.Current current)
    {
         System.Console.Out.WriteLine("received callback #" + num);
    }
}
