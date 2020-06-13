using System.Collections.Generic;

namespace FactoryMethod
{
    /// <summary>
    /// The 'Creator' abstract class
    /// - Declares the factory method, which returns an object of type Product. 
    /// - Creator may also define a default implementation of the factory method that returns a default ConcreteProduct object.
    /// - May call the factory method to create a Product object.
    /// </summary>
    public abstract class Document
    {
        public List<Page> Pages { get; } = new List<Page>();

        // Factory Method


        /// <summary>
        /// The "Factory Method" that must be implemented by subclasses.
        /// </summary>
        /// <returns>List of the Page's subclasses.</returns>
        public abstract void CreatePages();
    }
}
