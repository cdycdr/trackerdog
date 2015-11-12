﻿namespace TrackerDog
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Reflection;

    [ContractClassFor(typeof(IDeclaredObjectPropertyChangeTracking))]
    public abstract class IDeclaredObjectPropertyChangeTrackingContract : IDeclaredObjectPropertyChangeTracking
    {
        public object CurrentValue
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool HasChanged
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public object OldValue
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public PropertyInfo Property
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IObjectChangeTracker Tracker
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string PropertyName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        [ContractInvariantMethod]
        private void Invariants()
        {
            Contract.Invariant(Tracker != null);
            Contract.Invariant(Property != null);
            Contract.Invariant(Property.Name == PropertyName);
        }

        public bool Equals(IDeclaredObjectPropertyChangeTracking other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(IObjectPropertyChangeTracking other)
        {
            throw new NotImplementedException();
        }
    }
}