﻿/*
namespace Meep.Tech.Data.JsonModPorting {

  /// <summary>
  /// A resource based archetype that can be ported to/from a mod folder without the need of plugins/asseblies.
  /// 
  /// These types also require a private ctor with signagure with params:
  /// <para>
  /// string name,
  /// string resourceKey,
  /// string packageName,
  /// JObject config,
  /// Dictionary[string, object] importOptionsAndObjects
  /// </para>
  /// </summary>
  public interface IPortableArchetype {

    /// <summary>
    /// The unique resource key that can be used to identify this archetype and find it's mod folder.
    /// </summary>
    public string ResourceKey {
      get;
    }

    /// <summary>
    /// The package this archetype came from
    /// </summary>
    public string PackageKey {
      get;
    }

    /// <summary>
    /// The default package key for this archetype type
    /// </summary>
    public string DefaultPackageKey {
      get;
    }

    /// <summary>
    /// Generates a config file for this Archetype.
    /// </summary>
    JObject GenerateConfig();

    /// <summary>
    /// Must be overriden to un-load a portable archetype from current memory.
    /// TODO: a way to do this should be exposed as a protected member in the Archetype<,> class
    /// </summary>
    internal protected void Unload();
  }
}
*/