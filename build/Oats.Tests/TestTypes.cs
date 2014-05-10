﻿using System;

namespace Oats.Tests
{
	public enum SamplerMode
	{
		X,
		Y,
		Z
	}

	public sealed class ShaderSamplerDefinition
	{
		String niceName;

		public ShaderSamplerDefinition ()
		{
			this.Name = String.Empty;
		}

		public String NiceName
		{
			get { return (niceName == null) ? Name : niceName; }
			set { niceName = value; }
		}

		public String Name { get; set; }
		public Boolean Optional { get; set; }

		public SamplerMode SamplerMode { get; set; }

		public Boolean Equals(ShaderSamplerDefinition other)
		{
			return (
				(this.Name == other.Name) && 
				(this.NiceName == other.NiceName) && 
				(this.Optional == other.Optional) && 
				(this.SamplerMode == other.SamplerMode));
		}

		public override Boolean Equals(object obj)
		{
			Boolean flag = false;
			if (obj is ShaderSamplerDefinition)
			{
				flag = this.Equals((ShaderSamplerDefinition) obj);
			}
			return flag;
		}
	}
}
