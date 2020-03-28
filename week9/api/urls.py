from django.urls import path
from api import views

urlpatterns = [
    path('categories/', views.category_list),
    path('products/', views.product_list),
    path('categories/<int:pk>/', views.category_detail),
    path('products/<int:pk>/', views.product_detail),
    path('categories/<int:pk>/products', views.category_products)
]