namespace SwaggerTypeProvider

open FSharp.Control.Tasks
open SwaggerProvider

module TestSwagger =
 
    type CoursesApi = SwaggerClientProvider<"api.json">
    let client = CoursesApi.Client()
    let course =
        task {
            let! courses = client.ApiCoursesGet()

            for course in courses do
                do! client.ApiCoursesRejectStudentByCourseIdPost(course.Id.Value, "Max")
        }