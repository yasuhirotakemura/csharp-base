﻿namespace WinFormBase.Domain.Exceptions.Bases;

public abstract class ExceptionBase : Exception
{
    public ExceptionBase() : base()
    {
    }

    public ExceptionBase(string? message) : base(message)
    {
    }

    public ExceptionBase(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    public abstract ExceptionType ExceptionType { get; }
}

public enum ExceptionType
{
    Info,
    Warning,
    Error,
}