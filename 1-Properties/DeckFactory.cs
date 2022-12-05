namespace Properties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A factory class for building <see cref="ISet{T}">decks</see> of <see cref="Card"/>s.
    /// </summary>
    public class DeckFactory
    {
        private string[] _seeds;

        private string[] _names;

        // TODO improve
        public IList<string> Seeds
        {
            get{return this._seeds.ToList();}
            set{this._seeds = value.ToArray();}
        }

        // TODO improve
        public IList<string> Names
        {
            get{return this._names.ToString();}
            set{this._names=names.ToArray();}
        }

        // TODO improve
        public int DeckSize => this._names.Length * this._seeds.Length;

        /// TODO improve
        public ISet<Card> Deck
        {
            get
            {
            if (_names == null || _seeds == null)
            {
                throw new InvalidOperationException();
            }
            
            return new HashSet<Card>(Enumerable
                .Range(0, _names.Length)
                .SelectMany(i => Enumerable
                    .Repeat(i, _seeds.Length)
                    .Zip(
                        Enumerable.Range(0, _seeds.Length),
                        (n, s) => Tuple.Create(_names[n], _seeds[s], n)))
                .Select(tuple => new Card(tuple))
                .ToList());
             } }
    }
}
