<template>
  <div>Breadcrumb</div>
</template>
<script>
export default {
  name: "BreadCrumb",
  props: {
    pages: Array,
  },
  created: function () {
    console.log(this.$props.pages);
  },
  watch:{
      pages:function(){
          console.log(this.$props.pages)
      }
  }
};
</script>