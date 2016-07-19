using System.Collections.Generic;

namespace FizzBuzzUI {
    internal class FizzBuzz {
        private int max;

        public FizzBuzz(int max) {
            this.max = max;
        }

        public IEnumerable<string> Results { get; internal set; }
    }
}