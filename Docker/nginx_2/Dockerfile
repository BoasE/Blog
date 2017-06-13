FROM nginx
COPY /conf/nginx.conf /etc/nginx/nginx.conf
COPY /site /sites/mysite
EXPOSE 80
CMD ["nginx", "-g", "daemon off;"]
