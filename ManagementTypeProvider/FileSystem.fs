namespace ManagementTypeProvider

open FSharp.Management

module TestFileSystem =
    type Users = FileSystem<"C:\\Users">
    let s = Users.``All Users``.Path
    
    type UsersWithoutDrive = FileSystem<"C:\\Users", relativeTo = "C:">
    let s1 = UsersWithoutDrive.``All Users``.Path
    
    type Relative = RelativePath<".", watch = false>
    Relative.``..``.files.``test.txt``
    
    let p1 = Registry.HKEY_CURRENT_USER.Path
