// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.CobieExpress.Interfaces;
using Xbim.CobieExpress;

namespace Xbim.CobieExpress.Interfaces
{
	/// <summary>
    /// Readonly interface for CobieSystem
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @ICobieSystem : ICobieAsset
	{
		IEnumerable<ICobieComponent> @Components { get; }
	
	}
}

namespace Xbim.CobieExpress
{
	[IndexedClass]
	[ExpressType("System", 23)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieSystem : CobieAsset, IInstantiableEntity, ICobieSystem, IEqualityComparer<@CobieSystem>, IEquatable<@CobieSystem>
	{
		#region ICobieSystem explicit implementation
		IEnumerable<ICobieComponent> ICobieSystem.Components { get { return @Components; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieSystem(IModel model) : base(model) 		{ 
			Model = model; 
			_components = new ItemSet<CobieComponent>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<CobieComponent> _components;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 13)]
		public ItemSet<CobieComponent> @Components 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _components;
				((IPersistEntity)this).Activate(false);
				return _components;
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
				case 9: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 10: 
					if (_components == null) _components = new ItemSet<CobieComponent>( this );
					_components.InternalAdd((CobieComponent)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@CobieSystem other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @CobieSystem
            var root = (@CobieSystem)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@CobieSystem left, @CobieSystem right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@CobieSystem left, @CobieSystem right)
        {
            return !(left == right);
        }


        public bool Equals(@CobieSystem x, @CobieSystem y)
        {
            return x == y;
        }

        public int GetHashCode(@CobieSystem obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}