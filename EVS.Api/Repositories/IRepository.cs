using System.Linq.Expressions;

namespace EVS.Api.Repositories
{
    public interface IRepository<Entity> where Entity : class
    {
        /// <summary>
        /// Ajoute une entité au repository
        /// </summary>
        public Task<Entity?> Add(Entity entity);

        /// <summary>
        /// Retourne une entité par son id. Peut retourner null.
        /// </summary>
        public Task<Entity?> GetById(Guid id);

        /// <summary>
        /// Retourne une entité répondant à un prédicat. Peut retourner null.
        /// </summary>
        public Task<Entity?> Get(Expression<Func<Entity, bool>> predicate);

        /// <summary>
        /// Retourne toutes les entités
        /// </summary>
        public Task<List<Entity>> GetAll();

        /// <summary>
        /// Retourne les entités répondant à un prédicat
        /// </summary>
        public Task<List<Entity>> GetAll(Expression<Func<Entity, bool>> predicate);

        /// <summary>
        /// Met à jour une entité dans le repository
        /// </summary>
        /// <returns>l'entité mise à jour, null si erreur</returns>
        public Task<Entity?> Update(Entity entity);

        /// <summary>
        /// Supprime une entité du repository
        /// </summary>
        /// <returns>true si la suppression a été effectuée, false si la suppression n'a pas pu être faite ou si l'entité n'existe pas</returns>
        public Task<bool> Delete(Guid id);
    }
}
