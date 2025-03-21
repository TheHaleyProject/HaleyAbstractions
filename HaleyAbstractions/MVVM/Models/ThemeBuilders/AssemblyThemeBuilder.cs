﻿using System.Reflection;

namespace Haley.Models {
    public class AssemblyThemeBuilder : IndependentThemeBuilder {
        public string IndependentGroupReferenceId { get; }

        public Assembly Target { get; set; }
        public AssemblyThemeBuilder(Assembly target, string independentGroupReferenceId = null) {
            Target = target;
            IndependentGroupReferenceId = independentGroupReferenceId;
        }
        public AssemblyThemeBuilder(Assembly target) : this(target, null) { }

        public AssemblyThemeBuilder() : this(null, null) { }
    }
}
