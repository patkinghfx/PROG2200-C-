using System.Collections.Generic;

namespace SchoolTracker
{
    class Registrar
    {
        private List<IGraduate> grads;

        public Registrar(List<IGraduate> grads)
        {
            this.grads = grads;
        }

        public void GraduateAll()
        {
            foreach (var graduate in grads)
            {
                graduate.Graduate();
            }
        }
    }
}