// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.ProductExtension
{
	public partial class @IfcRelCoversBldgElements : IIfcRelCoversBldgElements
	{

		[CrossSchemaAttribute(typeof(IIfcRelCoversBldgElements), 5)]
		IIfcElement IIfcRelCoversBldgElements.RelatingBuildingElement 
		{ 
			get
			{
				return RelatingBuildingElement;
			} 
			set
			{
				RelatingBuildingElement = value as IfcElement;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcRelCoversBldgElements), 6)]
		IItemSet<IIfcCovering> IIfcRelCoversBldgElements.RelatedCoverings 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcCovering, IIfcCovering>(RelatedCoverings);
			} 
		}
	//## Custom code
	//##
	}
}