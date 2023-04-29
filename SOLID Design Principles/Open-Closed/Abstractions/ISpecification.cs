﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed.Abstractions
{
	public interface ISpecification<T>
	{
		bool IsSatisfied(T entity);
	}
}
