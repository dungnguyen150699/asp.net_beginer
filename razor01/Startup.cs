namespace config_startup
{
    public class Startup
    {

        // Đăng ký các dịch vụ sử dụng bởi ứng dụng, services là một DI container
        // Xem: https://xuanthulab.net/dependency-injection-di-trong-c-voi-servicecollection.html
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDistributedMemoryCache();       // Thêm dịch vụ dùng bộ nhớ lưu cache (session sử dụng dịch vụ này)
            //services.AddSession();                      // Thêm  dịch vụ Session, dịch vụ này cunng cấp Middleware: 
            // Thêm các dịch vụ liên quan đến Razor Page
            services.AddRazorPages();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            // Chuyển hướng https
            app.UseHttpsRedirection();
            // Kích hoạt truy cập file tĩnh (file trong wwwroot)
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                // Thêm endpoint chuyển đến các trang Razor Page
                // trong thư mục Pages
                endpoints.MapRazorPages();
            });

        }
    }
}