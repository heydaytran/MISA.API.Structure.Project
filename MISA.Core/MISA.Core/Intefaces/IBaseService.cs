using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Core.Intefaces
{
    // interface này dành cho thằng App để nó tương tác

    /// <summary>
    /// Base Service
    /// </summary>
    /// <typeparam name="MISAEntity">Kiểu của thực thể</typeparam>
    /// Create by: TVTHINH
    public interface IBaseService<MISAEntity>
    {
        /// <summary>
        /// Lấy toàn bộ dữ liệu của bảng trong database
        /// </summary>
        /// <returns> Danh sách đối tượng</returns>
        /// CreateBy : TVTHINH
        IReadOnlyList<MISAEntity> GetEntities();

        /// <summary>
        /// Lấy thông tin đối tượng theo khóa chính
        /// </summary>
        /// <param name="entityId"> ID của đối tượng</param>
        /// <returns> Một thực thể duy nhất có ID tương ứng</returns>
        MISAEntity GetById(Guid entityId);

        /// <summary>
        /// Thêm mới đối tượng
        /// </summary>
        /// <param name="entity"> đối tượng thực th</param>
        /// <returns> Số bản ghi được thêm mới thành công</returns>
        int Insert(MISAEntity entity);

        /// <summary>
        /// Sửa thông tin đối tượng
        /// </summary>
        /// <param name="entity"> Thực thể đã được chỉnh sửa</param>
        /// <param name="entityId"> ID của thực thể</param>
        /// <returns> Số bản ghi đã update được trong DB</returns>
        int Update(MISAEntity entity, Guid entityId);


        /// <summary>
        /// Xóa thông tin 1 đối tượng
        /// </summary>
        /// <param name="entityId"> Khóa chính của thực thể</param>
        /// <returns> Số bản ghi đã xóa được trong db</returns>
        int Delete(Guid entityId);
    }
}
