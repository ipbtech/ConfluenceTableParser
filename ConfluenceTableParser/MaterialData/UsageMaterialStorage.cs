using System.Collections;
using System.Collections.Generic;

namespace ConfluenceTableParser
{
    public class UsageMaterialStorage : IEnumerable<UsageMaterial>
    {
        private List<UsageMaterial> materials;
        public UsageMaterialStorage()
        {
            materials = new List<UsageMaterial>();
        }
        public void AddMaterialToStorage(UsageMaterial usageMaterial)
        {
            materials.Add(usageMaterial);
        }
        public IEnumerator<UsageMaterial> GetEnumerator()
        {
            return new UsageMaterialStorageEnumerator(materials);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new UsageMaterialStorageEnumerator(materials);
        }
    }
    public class UsageMaterialStorageEnumerator : IEnumerator<UsageMaterial>
    {
        private readonly List<UsageMaterial> materials;
        private int currentIndex = -1;
        public UsageMaterialStorageEnumerator(List<UsageMaterial> materials)
        {
            this.materials = materials;
        }
        public UsageMaterial Current => materials[currentIndex];
        object IEnumerator.Current => materials[currentIndex];
        public bool MoveNext()
        {
            currentIndex++;
            if (currentIndex >= materials.Count)
            {
                return false;
            }
            return true;
        }
        public void Reset()
        {
            currentIndex = -1;
        }
        public void Dispose() { }
    }
}
