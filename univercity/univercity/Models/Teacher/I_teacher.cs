using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace univercity.Models
{
  public  interface I_teacher
    {
        int insert_teacher(tbl_teacher_presonal_information tb);
        int delete_teacher(tbl_teacher_presonal_information tb);
        int update_teacher(tbl_teacher_presonal_information tb);
        int insert_listteacher(IEnumerable<tbl_teacher_presonal_information> list_teacher);
        int delete_listteacher(IEnumerable<tbl_teacher_presonal_information> list_teacher);
        tbl_teacher_presonal_information find_teacher(string code_national_teacher);
        List<tbl_teacher_presonal_information> find_teachers(string code_national_teacher);




    }
}
