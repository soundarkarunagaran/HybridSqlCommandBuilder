﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SqlCommandBuilder
{
    public interface ICommandBuilder
    {
        ICommandBuilder<T> From<T>();
    }

    public interface ICommandBuilder<T>
    {
        Command Build();

        ICommandBuilder<T> Where(string condition);
        ICommandBuilder<T> Where(Expression<Func<T, bool>> expression);
        ICommandBuilder<T> Select(params string[] columns);
        ICommandBuilder<T> Select(Expression<Func<T, object>> expression);
        ICommandBuilder<T> OrderBy(params string[] columns);
        ICommandBuilder<T> OrderBy(Expression<Func<T, object>> expression);
        ICommandBuilder<T> OrderByDescending(params string[] columns);
        ICommandBuilder<T> OrderByDescending(Expression<Func<T, object>> expression);
    }
}
