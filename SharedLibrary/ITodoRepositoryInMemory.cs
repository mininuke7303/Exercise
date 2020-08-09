using System.Collections.Generic;

namespace SharedLibrary {
    public interface ITodoRepositoryInMemory {

        void Add(Todo model);
        List<Todo> GetAll();
        

    }


}
